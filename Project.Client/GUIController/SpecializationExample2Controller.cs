using Common;
using Domain;
using Project.Client.ServerCommunication;
using Project.Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.ComponentModel;

namespace Project.Client.GUIController
{
    public class SpecializationExample2Controller
    {
        private UCSpecializationExample2 _userControll;
        private BindingList<Animal> _animals = new BindingList<Animal>();

        public SpecializationExample2Controller(UCSpecializationExample2 userControll)
        {
            _userControll = userControll;
            LoadTree();
            _userControll.DgvAnimals.DataSource = _animals;
        }

        private void LoadTree()
        {
            List<AnimalSpecies> animalSpecies = Communication.Instance.SendRequestGetResponse<List<AnimalSpecies>>(
                Operation.GET_ANIMAL_SPECIES_LIST
            );

            Console.WriteLine(animalSpecies.Count);

            BuildTree(animalSpecies);
        }

        private void BuildTree(List<AnimalSpecies> animalSpecies)
        {
            Dictionary<int, TreeNode> nodeDictionary = new Dictionary<int, TreeNode>();

            // Create nodes for all species
            foreach (AnimalSpecies species in animalSpecies)
            {
                TreeNode node = new TreeNode(species.Name)
                {
                     Tag = species
                };

                nodeDictionary[species.ID] = node;

                if (species.ParentID == 0)
                {
                    _userControll.AnimalSpeciesTree.Nodes.Add(node);
                }
            }

            foreach (AnimalSpecies species in animalSpecies)
            {
                if (species.ParentID != 0 && nodeDictionary.ContainsKey(species.ParentID))
                {
                    TreeNode parentNode = nodeDictionary[species.ParentID];
                    parentNode.Nodes.Add(nodeDictionary[species.ID]);
                }
            }
        }

        public void GetAnimalsFromSelectedNode()
        {
            TreeNode node = _userControll.AnimalSpeciesTree.SelectedNode;
            AnimalSpecies species = node != null ? (AnimalSpecies) node.Tag : null;
            
            if(node == null)
            {
               List<Animal> animals =  Communication.Instance.SendRequestGetResponse<List<Animal>>(Operation.GET_ANIMALS);
                foreach (Animal animal in animals)
                {
                    AnimalSpecies wantedSpecies = new AnimalSpecies();
                    wantedSpecies.ID = animal.SpeciesID;
                    AnimalSpecies specificSpecies = Communication.Instance.SendRequestGetResponse<AnimalSpecies>(Operation.GET_ANIMAL_SPECIES, wantedSpecies);
                    animal.Species = specificSpecies.Name;
                    _animals.Add(animal);
                }
                _userControll.DgvAnimals.Refresh();

            } else
            {
                _animals = new BindingList<Animal>();
                List<Animal> animals = Communication.Instance.SendRequestGetResponse<List<Animal>>(Operation.GET_ANIMAL_FOR_SPECIES, species);
                foreach (Animal animal in animals)
                {
                    AnimalSpecies wantedSpecies = new AnimalSpecies();
                    wantedSpecies.ID = animal.SpeciesID;
                    AnimalSpecies specificSpecies = Communication.Instance.SendRequestGetResponse<AnimalSpecies>(Operation.GET_ANIMAL_SPECIES, wantedSpecies);
                    animal.Species = specificSpecies.Name;
                    _animals.Add(animal);
                }
                _userControll.DgvAnimals.DataSource = _animals;
                _userControll.DgvAnimals.Refresh();

            }
        }
    }
}
