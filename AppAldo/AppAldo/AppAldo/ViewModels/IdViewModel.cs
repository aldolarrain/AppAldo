using AppAldo.Models;
using AppAldo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppAldo.ViewModels
{
    public class IdViewModel : BaseViewModel
    {
        //apiservice
        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private string albumid;
        private string title;
        private string url;
        #endregion

        #region Properties
        public string Albumid
        {
            get { return this.albumid; }
            set { SetValue(ref this.albumid, value); }
        }
        public string Title
        {
            get { return this.title; }
            set { SetValue(ref this.title, value); }
        }
        public string Url
        {
            get { return this.url; }
            set { SetValue(ref this.url, value); }
        }
        #endregion

        #region Constructor
        public IdViewModel()
        {
            this.apiService = new ApiService();
            this.LoadIdentificador();
        }
        #endregion

        #region Methods
        private async void LoadIdentificador()
        {
            //llamar API
            var identificador = await this.apiService.Get<IdModel>("https://jsonplaceholder.typicode.com/",
                "photos/",
                "1"
                );
            this.Albumid = identificador[0].AlbumId;
            this.Title = identificador[0].Title;
            this.Url = identificador[0].Url;
        }
        #endregion
    }
}
