namespace APBD_5.Animal;

public interface IAnimalService
{
    int? DeleteAnimal(int id);   
    IEnumerable<Animal> GetAnimals(string orderBy);
    Animal AddAnimal(Animal animal);
    Animal? UpdateAnimal(Animal animal);
}