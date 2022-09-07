using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de datos
/// </summary>
[Serializable]
[Table("datos", Schema = "public")]
public class Edatos
{
    private int id;
    private String proximidad;
    private String infrarrojo;
    private String temperatura;
    private String humedad;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("proximidad")]
    public string Proximidad { get => proximidad; set => proximidad = value; }
    [Column("infrarrojo")]
    public string Infrarrojo { get => infrarrojo; set => infrarrojo = value; }
    [Column("temperatura")]
    public string Temperatura { get => temperatura; set => temperatura = value; }
    [Column("humedad")]
    public string Humedad { get => humedad; set => humedad = value; }

}