using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PlataformaDeMembros.Models;

public class Member
{
     
    [DisplayName("Id")] 
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(80, ErrorMessage = "O Nome Deve Conter ate 80 Caracteres")]
    [MinLength(5, ErrorMessage = "O Nome Deve Conter no Minimo 5 Caracteres")]
    [DisplayName("Nome Completo")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe o Email")]
    [EmailAddress(ErrorMessage = "Email Invalido")]
    [DisplayName("E-Mail")]
    public string Email { get; set; } = string.Empty;
    

    public List<PremiumMembers> Premium { get; set; } = new();
}