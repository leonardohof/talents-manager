using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalentsManagerService.Data.Model;
using TalentsManagerService.Data.Repository;

namespace TalentsManagerService.Services
{
    public class TalentService
    {
        private TalentRepository talentRepository;

        public TalentService(TalentRepository talentRepository)
        {
            this.talentRepository = talentRepository;
        }

        public List<Talent> GetAll()
        {
            return talentRepository.GetAll().ToList();
        }

        public Talent GetById(Int64 id)
        {
            return talentRepository.GetById(id);
        }

        public void Create(Talent talent)
        {
            talentRepository.Add(talent);
            talentRepository.SaveChanges();
        }

        public void Update(long id, Talent talent)
        {
            talentRepository.Update(talent);
            talentRepository.SaveChanges();
        }

        public void Delete(long id)
        {
            talentRepository.Remove(id);
            talentRepository.SaveChanges();
        }
    }
}
