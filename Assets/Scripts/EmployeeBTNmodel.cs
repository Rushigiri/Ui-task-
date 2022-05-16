using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmployeeBTNmodel : MonoBehaviour
{
    public Employee employee;
    public Text nameTxt;

    public void SetButtonName(Employee currentEmployee)
    {
        employee = currentEmployee;
        nameTxt.text = employee.name;
    }

    public void OnButtonClick()
    {
        ScreenScript.Instance.empDataScreen.SetActive(true);
        ScreenScript.Instance.homeScreen.SetActive(false);
        ScreenScript.Instance.registerScreen.SetActive(false);
        PrintData.Instance.SetData(employee);

    }
}
