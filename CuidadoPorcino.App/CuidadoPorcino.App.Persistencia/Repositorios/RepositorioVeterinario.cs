using System;
using System.Collections.Generic;
using CuidadoPorcino.App.Dominio;
using System.Linq;

namespace CuidadoPorcino.App.Persistencia
{
    public class RepositorioVeterinario : INRepositorioVeterinario
    {
        private readonly AppContext _appContext; // crer objeto de la AppContex
        public RepositorioVeterinario(AppContext appContext) // crear el constructor
        {
            _appContext = appContext; // el parametro se igula con el objeto
        }
        Veterinario INRepositorioVeterinario.AddVeterinario(Veterinario veterinario) // metodo adicionar cerdo, retorna tipo cerdo
        {
            var veterinarioAdicionado = _appContext.Veterinarios.Add(veterinario);// crear variabale "cerdoAdicionado " de tipo var

            AsignarPersona(1, veterinario);

            //_appContext.Cerdos.Add(cerdo); se crea con tutor mercelo y funciona
            _appContext.SaveChanges(); // guardar cambios
            return veterinarioAdicionado.Entity;
            // return null; creado con tutor marcelo funciona
        }

        void INRepositorioVeterinario.DeleteVeterinario(int idVeterinario) // metodo eliminar cerdo, no retorna
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(p => p.IdVeterinario == idVeterinario); //buscar persona con el comando FirstOrDefault()
            if (veterinarioEncontrado == null)
            {
                return;
            }
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges(); // guardar cambios

        }

        IEnumerable<Veterinario> INRepositorioVeterinario.GetAllVeterinarios()//metodo para listar todos las personas
        {
            return _appContext.Veterinarios;
        }

        Veterinario INRepositorioVeterinario.GetVeterinario(int idVeterinario)// metodo para listar una persona
        {
            return _appContext.Veterinarios.FirstOrDefault(p => p.IdVeterinario == idVeterinario);
        }

        Veterinario INRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario) // metodo para mdificar una persona
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(p => p.IdVeterinario == veterinario.IdVeterinario);
            if (veterinarioEncontrado != null)
            {
                veterinarioEncontrado.IdVeterinario = veterinario.IdVeterinario;
                veterinarioEncontrado.TarjetaProfesional = veterinario.TarjetaProfesional;
                veterinarioEncontrado.persona = veterinario.persona;

                _appContext.SaveChanges();
            }
            return veterinarioEncontrado;
        }

        public Persona AsignarPersona(int idPersona, Veterinario veterinario)
        {
            var personaEncontrado = _appContext.Personas.FirstOrDefault(j => j.IdPersona == idPersona);
            if (personaEncontrado != null)
            {
                veterinario.persona = personaEncontrado;
                _appContext.SaveChanges();
                return personaEncontrado;
            }
            return null;
        }
    }
}