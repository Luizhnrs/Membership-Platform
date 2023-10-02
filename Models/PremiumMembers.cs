using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PlataformaDeMembros.Models;

public class PremiumMembers
{
    [Key] [DisplayName("id")] public int id { get; set; }

    [Required(ErrorMessage = "Informe o titulo do Premium")]
    [StringLength(80, ErrorMessage = "O titulo deve conter ate 80 caracteres")]
    [MinLength(5, ErrorMessage = "O titulo deve conter no minimo 5 caracteres")]

    [DisplayName("Titulo")]
    public string Title { get; set; } = string.Empty;
    
    [DataType(DataType.DateTime)]
    [DisplayName("Inicio")]
    public DateTime StartDate { get; set; }
    
    [DataType(DataType.DateTime)]
    [DisplayName("Termino")]
    public DateTime EndDate { get; set; }
    
    [DisplayName("Membro")]
    [Required(ErrorMessage = "Membro Invalido")]
    public int MemberId { get; set; }
    
    public Member? Member { get; set; }
}