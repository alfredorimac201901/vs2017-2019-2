﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.UI.Web.WebForm.MantenimientosService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MantenimientosService.IMantenimientosService")]
    public interface IMantenimientosService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosService/GetArtistAll", ReplyAction="http://tempuri.org/IMantenimientosService/GetArtistAllResponse")]
        System.Collections.Generic.List<App.Entities.Base.Artist> GetArtistAll(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosService/GetArtistAll", ReplyAction="http://tempuri.org/IMantenimientosService/GetArtistAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<App.Entities.Base.Artist>> GetArtistAllAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosService/GetArtist", ReplyAction="http://tempuri.org/IMantenimientosService/GetArtistResponse")]
        App.Entities.Base.Artist GetArtist(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosService/GetArtist", ReplyAction="http://tempuri.org/IMantenimientosService/GetArtistResponse")]
        System.Threading.Tasks.Task<App.Entities.Base.Artist> GetArtistAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosService/SaveArtist", ReplyAction="http://tempuri.org/IMantenimientosService/SaveArtistResponse")]
        bool SaveArtist(App.Entities.Base.Artist entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosService/SaveArtist", ReplyAction="http://tempuri.org/IMantenimientosService/SaveArtistResponse")]
        System.Threading.Tasks.Task<bool> SaveArtistAsync(App.Entities.Base.Artist entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosService/DeleteArtist", ReplyAction="http://tempuri.org/IMantenimientosService/DeleteArtistResponse")]
        bool DeleteArtist(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosService/DeleteArtist", ReplyAction="http://tempuri.org/IMantenimientosService/DeleteArtistResponse")]
        System.Threading.Tasks.Task<bool> DeleteArtistAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMantenimientosServiceChannel : App.UI.Web.WebForm.MantenimientosService.IMantenimientosService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MantenimientosServiceClient : System.ServiceModel.ClientBase<App.UI.Web.WebForm.MantenimientosService.IMantenimientosService>, App.UI.Web.WebForm.MantenimientosService.IMantenimientosService {
        
        public MantenimientosServiceClient() {
        }
        
        public MantenimientosServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MantenimientosServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MantenimientosServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MantenimientosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<App.Entities.Base.Artist> GetArtistAll(string nombre) {
            return base.Channel.GetArtistAll(nombre);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<App.Entities.Base.Artist>> GetArtistAllAsync(string nombre) {
            return base.Channel.GetArtistAllAsync(nombre);
        }
        
        public App.Entities.Base.Artist GetArtist(int id) {
            return base.Channel.GetArtist(id);
        }
        
        public System.Threading.Tasks.Task<App.Entities.Base.Artist> GetArtistAsync(int id) {
            return base.Channel.GetArtistAsync(id);
        }
        
        public bool SaveArtist(App.Entities.Base.Artist entity) {
            return base.Channel.SaveArtist(entity);
        }
        
        public System.Threading.Tasks.Task<bool> SaveArtistAsync(App.Entities.Base.Artist entity) {
            return base.Channel.SaveArtistAsync(entity);
        }
        
        public bool DeleteArtist(int id) {
            return base.Channel.DeleteArtist(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteArtistAsync(int id) {
            return base.Channel.DeleteArtistAsync(id);
        }
    }
}
