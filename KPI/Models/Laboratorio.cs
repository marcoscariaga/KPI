using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KPI.Models;

[Table("Laboratorio")]
[Index("Sigla", "Nome", Name = "UQ__Laborato__16413BD66BCEF5F8", IsUnique = true)]
public partial class Laboratorio
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Sigla { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string NomeDeContato { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string TelefoneDeContato { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? Telefone2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Logradouro { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? TipoLogradouro { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CodigoLogradouro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Numero { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Cidade { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Uf { get; set; } = null!;

    public int CepNumero { get; set; }

    public short CepComplemento { get; set; }

    [InverseProperty("Laboratorio")]
    public virtual ICollection<Laudo> Laudos { get; set; } = new List<Laudo>();

    [InverseProperty("Laboratorio")]
    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();

    [InverseProperty("Laboratorio")]
    public virtual ICollection<TermoApreensaoAmostraAnalise> TermoApreensaoAmostraAnalises { get; set; } = new List<TermoApreensaoAmostraAnalise>();
}
