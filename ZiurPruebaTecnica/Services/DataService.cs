using System.Collections.Generic;
using System.Net.Http.Headers;
using ZiurPruebaTecnica.Models;
using static System.Net.WebRequestMethods;

namespace ZiurPruebaTecnica.Services;

public class DataService(HttpClient http)
{
    public async Task<List<Documento>> GetDocumentosAsync()
    {

        var token = "ae8bad44-7348-11ee-b962-0242ac120002";
        http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var url = "https://mainserver.ziursoftware.com/Ziur.API/basedatos_01/ZiurServiceRest.svc/api/DocumentosFillsCombos";
        var response = await http.GetFromJsonAsync<List<Documento>>(url);

        return response ?? new List<Documento>();
    }
}
