using ObjectComposition.Entities.Enums

namespace ObjectComposition.Entities
{
    class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }


    }
}
