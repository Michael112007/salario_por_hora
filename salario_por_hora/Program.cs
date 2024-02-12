// See https://aka.ms/new-console-template for more information
Console.WriteLine("salario_por_horas");


    {
        double pagoPorHora, horasTrabajadas, sueldoBruto, descuentoAFP, descuentoSFS, totalDescuento, sueldoNeto;

        Console.Write("Ingrese el pago por hora: ");
        pagoPorHora = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese las horas trabajadas: ");
        horasTrabajadas = Convert.ToDouble(Console.ReadLine());

        sueldoBruto = pagoPorHora * horasTrabajadas;
        descuentoAFP = sueldoBruto * 0.0287;
        descuentoSFS = sueldoBruto * 0.0304;
        totalDescuento = descuentoAFP + descuentoSFS;
        sueldoNeto = sueldoBruto - totalDescuento;

        Console.WriteLine("Sueldo bruto: " + sueldoBruto);
        Console.WriteLine("Descuento AFP: " + descuentoAFP);
        Console.WriteLine("Descuento SFS: " + descuentoSFS);
        Console.WriteLine("Total descuento: " + totalDescuento);
        Console.WriteLine("Sueldo neto: " + sueldoNeto);
    }

