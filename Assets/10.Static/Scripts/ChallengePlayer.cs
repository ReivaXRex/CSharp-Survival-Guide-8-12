using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengePlayer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HelperMethods.ObjectColorChange(this.gameObject);
        }     
    }

    public class Employee
    {
        public int employeeID;
        public string first, last;
        public int salary;

        public static string company;

        public Employee()
        {
            Debug.Log("Instance Members Initialized");
        }

        static Employee()
        {
            company = "GameDevHQ";
            Debug.Log("Static Members Initialized");
        }

        void Start()
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            Employee e4 = new Employee();
            Employee e5 = new Employee();

        }

        // Output: "Static Members Initialized" (1)
        // "Instance Members Initialized" (1)
        // "Instance Members Initialized" (1)
        // "Instance Members Initialized" (1)
        // "Instance Members Initialized" (1)
        // "Instance Members Initialized" (1)
    }
}
