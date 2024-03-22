namespace GitHub;

public class parking{

    private List <string> vehiclesPlate = new List<string>(){get; set;};
    private string plate{ get; set; };
    private int hours{ get; set; };

    private price{ get; set; };
    public string date{ get; set};

    private option{ get; set; };

    public parking(string plate,int hours,int option){

        this.plate = plate;
        this.hours = hours;
        this.price = 5;
        this.date = DateTime.Now.ToString();
        this.option= option;

    }

    public int MenuOptions(){

        switch (option){
            case 1:

                plate = Console.Write("Digite a Placa do Veiculo: ");
                this.vehiclesPlate = Add(plate)
                break;

            case 2:

                plate = Console.Write("digite a Placa do Veiculo: ");
                //fazer método de verificação de veiculo 
                break; 

            case 3:

                console.WriteLine("Veiculos estacionados: ");
                foreach (string vehicle in vehicles){
                    Console.WriteLine(vehicle);
                }

                break;
            case 4:
            
                Console.WriteLine("Menu Encerrado");
                return;                
                break;

            default:
        }

    }

    public int calculatePrice(){

        price *= hours;
        get {return price};

    }
    
}
