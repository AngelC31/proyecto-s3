//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiGhost
{
    using System;
    using System.Collections.Generic;
    
    public partial class Monitoreo1
    {
        public int RowNumber { get; set; }
        public Nullable<int> EventClass { get; set; }
        public string TextData { get; set; }
        public string ApplicationName { get; set; }
        public string NTUserName { get; set; }
        public string LoginName { get; set; }
        public Nullable<int> CPU { get; set; }
        public Nullable<long> Reads { get; set; }
        public Nullable<long> Writes { get; set; }
        public Nullable<long> Duration { get; set; }
        public Nullable<int> ClientProcessID { get; set; }
        public Nullable<int> SPID { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public byte[] BinaryData { get; set; }
    }
}
