using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetData : MonoBehaviour
{
    [System.Serializable]
    public class EmpDetails
    {
        public string name;
        public string email;
        public string gender;
        public string address;
        public string desigation;
        public long contact;
        public int id;
    }

    public InputField nameInput;
    public InputField emailInput;
    public InputField contactInput; 
    public InputField idInput;
    public InputField addInput;
    public Dropdown genderInput;
    public Dropdown designationInput;

    public EmpBehaviour getDetails;

    public bool CheckEmp()
    {
        if (nameInput.text == "")
        {
            Debug.Log("Enter Your Name");
            return false;
        }
        if (emailInput.text == "")
        {
            Debug.Log("Enter Your Email");
            return false;
        }
        if (contactInput.text == "")
        {
            Debug.Log("Enter Your Number");
            return false;
        }
        if (idInput.text == "")
        {
            Debug.Log("Enter Your id");
            return false;
        }
        if (addInput.text == "")
        {
            Debug.Log("Enter Your Address");
            return false;
        }
       
            return true;
        

    }

    public void SubmitData()
    {
        if(CheckEmp())
        {
            Employee empObj = new Employee();
            empObj.name = nameInput.text;
            empObj.email = emailInput.text;
            empObj.address = addInput.text;
            empObj.contact = long.Parse(contactInput.text);
            empObj.id = int.Parse(idInput.text);
            empObj.gender =(Employee.genderType) genderInput.value;
            empObj.designation = (Employee.designationType) designationInput.value;
            getDetails.empList.Add(empObj);
           
        }
    }

  

    //private void Start()
    //{
    //    Debug.Log("stared");
    //}
    //private void Update()
    //{
    //    Debug.Log("update");

    //}


}
