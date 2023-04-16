using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class BookApiClient
    {
        internal static HttpClient? Connection { get; private set; }

        public static void initializeConnection()
        {
            Connection = new HttpClient();
            Connection.DefaultRequestHeaders.Accept.Clear();
            Connection.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<List<Book>> GetBooks(string value, string searchField)
        {
            string address = $"https://www.googleapis.com/books/v1/volumes?q={searchField}:{ value }";
            using (HttpResponseMessage response = await Connection.GetAsync(address))
            {
                if (response.IsSuccessStatusCode)
                {
                    VolumeList volumes = await response.Content.ReadAsAsync<VolumeList>();

                    List<Book> books = new List<Book>();
                    if (volumes != null)
                    {
                        if (volumes.items != null)
                        {
                            foreach (Volume volume in volumes.items)
                            {
                                Debug.WriteLine($"BookApiClient volume: {volume.volumeInfo.publishedDate}");
                                books.Add(new Book(volume));
                            }
                        }
                    }
                    return books;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
