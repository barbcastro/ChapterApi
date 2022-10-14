﻿using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext: DbContext
    {
        public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options):base(options)
        {
        }
        //vamos utilizar esse método para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(optionsBuilder.IsConfigured)
            {   //cada provedor tem sua sintaxe para especificação.
                optionsBuilder.UseSqlServer("Data Source = BARBARA-CASTRO\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }
        //Db representa as entidades que serão utilizadas de leitura, criação, atualização
        public DbSet<Livro> Livros { get; set; }
    }
}
