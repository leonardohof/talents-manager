using TalentsManagerService.Data.Model;

namespace TalentsManagerService.Data.Repository
{
    public class TalentRepository : Repository<Talent>
    {
        public TalentRepository(TalentsDbContext context)
            : base(context)
        {

        }
    }
}
