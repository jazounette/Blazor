using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages  {
    public class CounterBase: ComponentBase, IDisposable  {

        [Parameter]
        public string Id { set; get; }
        public int InitialCount { get; set; }

        protected bool Loading { get; set; }
        protected string Couleur { get; set; }

        protected int currentCount = 0;

        protected void IncrementCount()   {
            currentCount++;
            this.Couleur = currentCount > 10 ? "Red" : "Pink";
        }

        protected override void OnInitialized()    {     // appelé une seule fois au démarrage du composant
            Loading = true;

            _ = Task.Delay(5000).ContinueWith(x => { this.Loading = false; InvokeAsync(StateHasChanged); });    //_ variable dummy

            base.OnInitialized();
        }
        protected override void OnParametersSet()  {    // apellé quand des données transite entre le parent et l'enfant

            base.OnParametersSet();
        }
        protected override void OnAfterRender(bool firstRender)  {  // apelé après que le composant soit complétement chargé 
            base.OnAfterRender(firstRender);                        //firstrender true pour le premier rendu, après vaux false
        }
        protected override bool ShouldRender()  {               //permet de testé si le composant doit être rendu où non
            return base.ShouldRender();                         //le composant est rendu si le return est true, si le return est false il n'est pas rendu
        }

        public void Dispose() {                                 //code à executer quand le composant sera détruit
            throw new NotImplementedException();
        }
  


    }
}
