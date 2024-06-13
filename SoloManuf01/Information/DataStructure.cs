namespace SoloManuf01.Information;

public class Customer{
    public required string Name{ get; set; }
}

public class Material{
    public required string Name{ get; set; }
    //If not null, it's personification material
    public Customer? Customer{ get; set; } 
}

public class MaterialTube{
    public required Material Material{ get; set; }
    public required float Quantity{ get; set; }
    public required bool Separable{ get; set; }
}

//Reaction
public class MaterialQty{
    public required Material Material{ get; set; }
    public required float Quantity{ get; set; }
}


public class Reaction{
    public required List<MaterialQty> InputMaterials { get; set; }
    public required List<MaterialQty> OutputMaterials { get; set; }
    public required int TimeOfReaction  { get; set; }
}

public class ManufacturingChain{
    public required List<Reaction> Reactions { get; set; }
}


public class TubeContainer{
    public required List<MaterialTube> Tubes{ get; set; }
}

public class ProductionMachine{
    public required TubeContainer InputContainer  { get; set; }
    public required TubeContainer OutputContainer  { get; set; }
    public required Reaction Reaction { get; set; }
}

public class ProductionDepartment{
    public List<ProductionMachine> ProductionMachines { get; set; }
}


public class DataStructure{
    
}