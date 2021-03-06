
using System;

namespace GestionVeterinariaGenNHibernate.EN.GestionVeterinaria
{
public partial class VacunaEN                   :                           GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.TratamientoEN


{
/**
 *
 */

private string tipo;





public virtual string Tipo {
        get { return tipo; } set { tipo = value;  }
}





public VacunaEN() : base ()
{
}



public VacunaEN(string nombre, string tipo, Nullable<DateTime> fechaInicio, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, float precio, Nullable<DateTime> fechaFin)
{
        this.init (nombre, tipo, fechaInicio, consulta, precio, fechaFin);
}


public VacunaEN(VacunaEN vacuna)
{
        this.init (vacuna.Nombre, vacuna.Tipo, vacuna.FechaInicio, vacuna.Consulta, vacuna.Precio, vacuna.FechaFin);
}

private void init (string nombre, string tipo, Nullable<DateTime> fechaInicio, System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.ConsultaEN> consulta, float precio, Nullable<DateTime> fechaFin)
{
        this.Nombre = nombre;


        this.Tipo = tipo;

        this.FechaInicio = fechaInicio;

        this.Consulta = consulta;

        this.Precio = precio;

        this.FechaFin = fechaFin;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        VacunaEN t = obj as VacunaEN;
        if (t == null)
                return false;
        if (Nombre.Equals (t.Nombre))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nombre.GetHashCode ();
        return hash;
}
}
}
