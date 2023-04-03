using KarimiApp.Model;
using KarimiApp.Server.Repository.Repository;
using KarimiApp.Workstation.Server.Repository.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using ArvinWorkstation = Arvin.Net.Workstation;

namespace KarimiApp.Server.Api
{
 
    public class WorkstationServerController : ApiController
    {
        private List<ArvinWorkstation> loadedList;
        private IWorkstationServer workstationUnit;

       
        public WorkstationServerController(List<ArvinWorkstation> loadedList)
        {
            this.loadedList = loadedList;
            workstationUnit = new WorkstationServerRepository(loadedList);
        }

        public IHttpActionResult SendMessage([FromBody]WorkStationMessageModel workStationMessage)
        {
            return Ok(this.workstationUnit.SendMessage(workStationMessage));
        }
   
        public IHttpActionResult SendPlu([FromBody]WorkstationPluModel workstationPlu)
        {
            try
            {
                return Ok( this.workstationUnit.SendPlu(workstationPlu));
            }
            catch (System.Exception e)
            {

                return Ok(e.Message);
            }
           
        }
       
        public IHttpActionResult SendHardKey([FromBody] WorkstationHardKeyModel workstationHardKey)
        {
            return Ok(this.workstationUnit.SendHardKey(workstationHardKey));
        }

        public IHttpActionResult TotalReceiptAmount([FromBody]WorkstationModel workstation)
        {
            var res = this.workstationUnit.TotalReceiptAmount(workstation.Title);
            return Ok(res);
        }
      
        public IHttpActionResult TotalReceiptAmountForDate([FromBody]ReceiptModel receipt)
        {
            return Ok(this.workstationUnit.TotalReceiptAmountForDate(receipt));
        }
        public IHttpActionResult TotalReceiptCount([FromBody]WorkstationModel workstation)
        {
            return Ok(this.workstationUnit.TotalReceiptCount(workstation.Title));
        }
        public IHttpActionResult TotalReceiptCountForDate([FromBody]ReceiptModel receipt)
        {
            return Ok(this.workstationUnit.TotalReceiptCountForDate(receipt));
        }

    
    }
}
