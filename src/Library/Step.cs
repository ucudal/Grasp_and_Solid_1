//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }


        /*Yo creo que acá se usan tanto el patrón Expert como el principio SRP 
        porque la clase Step es la que se encarga de saber el costo y entonces 
        el código es más fácil de modificar. */
        public double CostoStep(){ //Todos en "double" porque ya estoy usando double. 

            double costoProducto = 0;

            double costoEquipamiento = 0;

            double costoTotal = 0; 
            //

            costoProducto = Input.UnitCost * Quantity;

            costoEquipamiento = Equipment.HourlyCost * Time;

            costoTotal = costoProducto * costoEquipamiento;

            return costoTotal;

        }
    }
}