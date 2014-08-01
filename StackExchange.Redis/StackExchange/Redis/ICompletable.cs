using System.Text;

namespace Misakai.Storage.Redis
{
    interface ICompletable
    {
        void AppendStormLog(StringBuilder sb);

        bool TryComplete(bool isAsync);
    }
}
