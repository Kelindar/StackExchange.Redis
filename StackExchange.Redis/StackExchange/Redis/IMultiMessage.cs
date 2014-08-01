using System.Collections.Generic;

namespace Misakai.Storage.Redis
{
    internal interface IMultiMessage
    {        IEnumerable<Message> GetMessages(PhysicalConnection connection);
    }
}
