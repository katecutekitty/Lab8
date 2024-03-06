using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Factory
    {
        public List<GentleSmartphone> Smartphones;
        public List<Customer> Customers;

        public Factory(List<Customer> customers)
        {
            Smartphones = new List<GentleSmartphone>();
            this.Customers = customers;
        }

        public void SaleSmartphone()
        {
            foreach (var customer in Customers.ToList())
            {
                customer.TransformModule = new Transformator();

                foreach (var smartphone in Smartphones.ToList())
                {
                    if (customer.GentleRate <= smartphone.Sensor.Sensitivity * 2 && customer.GentleRate >= smartphone.Sensor.Sensitivity / 1.5)
                    {
                        customer.Smartphone = smartphone;
                        customer.TransformModule = null;
                        Smartphones.Remove(smartphone);
                        break;
                    }
                }
                if (customer.TransformModule != null)
                {
                    foreach (var smartphone in Smartphones.ToList())
                    {

                        if (customer.GentleRate * 1.5 < smartphone.Sensor.Sensitivity)
                        {
                            customer.TransformModule.transformatorType = Transformator.TransformatorType.Multiplier;
                            if (customer.GentleRate * 1.5 * 2 < smartphone.Sensor.Sensitivity)
                            {
                                continue;
                            }
                            else
                            {
                                customer.Smartphone = smartphone;
                                Smartphones.Remove(smartphone);
                                break;
                            }

                        }
                        else if (customer.GentleRate > smartphone.Sensor.Sensitivity * 2)
                        {
                            customer.TransformModule.transformatorType = Transformator.TransformatorType.Divider;
                            if (customer.GentleRate / 2 > smartphone.Sensor.Sensitivity * 2)
                            {
                                continue;
                            }
                            else
                            {
                                customer.Smartphone = smartphone;
                                Smartphones.Remove(smartphone);
                                break;
                            }
                        }
                        else
                        {
                            customer.TransformModule = null;
                            break;
                        }
                    }
                }
            }
            if (Smartphones.Count > 0)
            {
                Smartphones.Clear();
            }
        }
    }
}
