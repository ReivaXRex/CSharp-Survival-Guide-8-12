using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    public Customer customer1;
    public Customer customer2;
    public Customer customer3;

    private void Start()
    {
        customer1 = new Customer();
        customer1.firstName = "Alf";
        customer1.lastName = "Burns";
        customer1.age = 46;
        customer1.gender = "Male";
        customer1.occupation = "Doctor";

        customer2 = new Customer("Charles", "Dickens", "Writer", "Male", 37);

        customer3 = CreateCustomer("Emelia", "Ford", "Lawyer", "Female", 54);

    }

    private Customer CreateCustomer(string firstname, string lastname, string gender, string occupation, int age)
    {
        Customer customer = new Customer(firstname, lastname, gender, occupation, age);
        return customer;
    }

   // public ChallengeCustomer[] customers;
}
