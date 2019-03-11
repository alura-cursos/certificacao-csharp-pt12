using System;
using System.Linq;
using Filmes.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Filmes
{
    public class SeedData
    {
        private readonly IWebHost webHost;
        private readonly IServiceProvider serviceProvider;
        public SeedData(IWebHost webHost)
        {
            this.webHost = webHost;
            using (var scope = webHost.Services.CreateScope())
            {
                this.serviceProvider = scope.ServiceProvider;
            }
        }

        public void Initialize()
        {
            FilmesContext contexto = serviceProvider.GetService<FilmesContext>();
            contexto.Database.EnsureCreated();

            if (contexto.Filme.Count() == 0)
            {
                Filme filme1 = new Filme(diretor: "James Cameron", titulo: "Titanic", duracaoMinutos: 194);
                Filme filme2 = new Filme(diretor: "James Cameron", titulo: "Avatar", duracaoMinutos: 162);
                Filme filme3 = new Filme(diretor: "James Cameron", titulo: "O Exterminador do Futuro", duracaoMinutos: 107);
                contexto.Filme.Add(filme1);
                contexto.Filme.Add(filme2);
                contexto.Filme.Add(filme3);
                contexto.SaveChanges();
            }
        }
    }

}
