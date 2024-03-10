using Common;

namespace Server
{
    public interface OperationHandler
    {
        Response Handle(Request request);
    }
}
