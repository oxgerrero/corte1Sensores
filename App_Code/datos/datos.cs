using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class datos
{
    public Edatos obDatos()
    {
        Edatos dev=null;
        List<Edatos> lista;
        using (var db = new mapeo())
        {
             lista= (List<Edatos>)db.Db_datos.OrderBy(x => x.Id).ToList();
        }
        foreach (Edatos dato in lista)
        {
            dev = dato;
        }
        return dev;
    }
    public void insertarDatos(Edatos datos)
    {
        using (var db = new mapeo())
        {
            db.Db_datos.Add(datos);
            db.SaveChanges();
        }
    }
}