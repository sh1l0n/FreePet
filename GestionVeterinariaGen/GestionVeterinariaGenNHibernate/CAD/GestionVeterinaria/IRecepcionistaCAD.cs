
using System;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace GestionVeterinariaGenNHibernate.CAD.GestionVeterinaria
{
public partial interface IRecepcionistaCAD
{
RecepcionistaEN ReadOIDDefault (string DNI);

string New_ (RecepcionistaEN recepcionista);

void Modify (RecepcionistaEN recepcionista);


void Destroy (string DNI);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN> DameTodoLosRecepcionistas ();


RecepcionistaEN BuscarRecepPorOID (string DNI);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN> BuscarRecepPorNombre (string busqueda);


System.Collections.Generic.IList<GestionVeterinariaGenNHibernate.EN.GestionVeterinaria.RecepcionistaEN> BuscarRecepPorApellidos (string busqueda);
}
}