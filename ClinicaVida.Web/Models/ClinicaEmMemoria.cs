namespace ClinicaVida.Web.Models;
public static class ClinicaEmMemoria
{
 public static List<Especialidade> Especialidades { get; } = new()
 {
 new Especialidade { Id = 1, Nome = "Cardiologia", Descricao = "Coração e vasos" },
 new Especialidade { Id = 2, Nome = "Pediatria", Descricao = "Saúde de crianças" },
 new Especialidade { Id = 3, Nome = "Dermatologia", Descricao = "Pele, cabelos e unhas" },
 new Especialidade { Id = 4, Nome = "Ortopedia", Descricao = "Ossos e articulações" },
 };
 public static List<Medico> Medicos { get; } = new()
 {
 new Medico { Id = 1, Nome = "Dra. Helena Godoi", Crm = "55221", EspecialidadeId = 1 },
 new Medico { Id = 2, Nome = "Dr. Caio Castro", Crm = "55222", EspecialidadeId = 2 },
 new Medico { Id = 3, Nome = "Dra. Elaine Prado", Crm = "55223", EspecialidadeId = 1 },
 new Medico { Id = 4, Nome = "Dr. Rodrigo Reis", Crm = "55224", EspecialidadeId = 4 },
 new Medico { Id = 5, Nome = "Dra. Gabriela Brandão", Crm = "55225", EspecialidadeId = 2 },
 new Medico { Id = 6, Nome = "Dr. Gustavo Lemos", Crm = "55226", EspecialidadeId = 3 },
 };
}

