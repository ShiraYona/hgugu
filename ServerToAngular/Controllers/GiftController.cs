using Microsoft.AspNetCore.Mvc;
using ServerToAngular.Models;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
namespace ServerToAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GiftController : ControllerBase
    {
        public static List<Gift> gifts = new List<Gift>
        {
            new Gift(1,"camera","aaa",30,"1.png","biggg") ,
            new Gift(2,"car","bbb",40,"2.png","fastttt"),
            new Gift(3,"house","ccc",50,"3.png","gggg"),
            new Gift(4,"gift","aaa",60,"4.png","jgdkj")
        };
        public static List<Donor> donors = new List<Donor>
        {
            new Donor(1,"aaa","aaaaaaaaaa") ,
            new Donor(2,"bbb","bbbbbbbbbb"),
            new Donor(3,"ccc","cccccccccc"),
            new Donor(4,"ddd","dddddddddd")
        };
        [Route("GetGifts")]
        [HttpGet]
        public List<Gift> GetGifts()
        {
            return gifts;
        }

        [Route("AddGift")]
        [HttpPost]
        public int AddGift([FromBody] Gift gift)
        {
            if (gift.Id <= 0)
            {
                var max = gifts.Max(x => x.Id);
                gift.Id = max + 1;
            }
            gifts.Add(gift);
            return gift.Id;
        }
        [Route("UpdateGift")]
        [HttpPut]
        public bool UpdateGift([FromBody] Gift gift)
        {
            var g = gifts.FirstOrDefault(x => x.Id == gift.Id);
            if (g != null)
            {
                g.Name = gift.Name;
                g.Donor = gift.Donor;
                g.Cost = gift.Cost;
                g.Image = gift.Image;
                g.Description = gift.Description;
                return true;
            }
            return false;
        }
        [Route("DeleteGift")]
        [HttpPost]
        public bool DeleteGift(int id)
        {
            var g = gifts.FirstOrDefault(x => x.Id == id);
            if (g != null)
            {
                gifts.Remove(g);
                return true;
            }
            return false;
        }
        [Route("Get/{id}")]
        [HttpGet]
        public Gift GetById(int id)
        {
           return gifts.FirstOrDefault(x => x.Id == id);
        }

    ///donor:
        [Route("GetDonors")]
        [HttpGet]
        public List<Donor> GetDonors()
        {
          return donors;
        }

        [Route("AddDonor")]
        [HttpPost]
        public int AddDonor([FromBody] Donor donor)
        {
          if (donor.Id <= 0)
          {
            var max = donors.Max(x => x.Id);
            donor.Id = max + 1;
          }
          donors.Add(donor);
          return donor.Id;
        }

        [Route("UpdateDonor")]
        [HttpPut]
        public bool UpdateDonor([FromBody] Donor donor)
        {
          var g = donors.FirstOrDefault(x => x.Id == donor.Id);
          if (g != null)
          {
            g.Name = donor.Name;
            g.Email = donor.Email;
          
            return true;
          }
          return false;
        }

        [Route("DeleteDonor")]
        [HttpPost]
        public bool DeleteDonor(int id)
        {
          var d = donors.FirstOrDefault(x => x.Id == id);
          if (d != null)
          {
            donors.Remove(d);
            return true;
          }
          return false;
        }

        [Route("GetDonor/{id}")]
        [HttpGet]
        public Donor GetDonorById(int id)
        {
          return donors.FirstOrDefault(x => x.Id == id);
        }

  }
}

