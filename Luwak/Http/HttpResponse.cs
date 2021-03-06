using System.Net;
using System.Text;

namespace WebServerProgram.Http;

public class HttpResponse
{
    public HttpHeader headers = new HttpHeader();
    public int status = (int) HttpStatusCode.OK;
    public string statusMessage = HttpStatusCode.OK.ToString();
    public byte[] content = new byte[0];

    public HttpResponse() {
        headers.AddHeader("Server", "Luwak");
        headers.AddHeader("Date", DateTime.Now.ToString());
    }
}
