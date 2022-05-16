using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScript : MonoBehaviour
{
    public List<Toggle> empType;
    List<Employee> selectedEmp = new List<Employee>();
    List<EmployeeBTNmodel> btnObj = new List<EmployeeBTNmodel>();

    Employee.designationType selectedEmpType;

    public EmpBehaviour getData;
    public EmployeeBTNmodel btnPrefab;
    public Transform content;


    private void Start()
    {
        foreach (Toggle toggle in empType)
        {
            toggle.onValueChanged.AddListener(OnValueChanged);
        }

    }
    void GenerateEmployeeObjs(int count)
    {
        for (int i = 0; i < count; i++)
        {
            EmployeeBTNmodel empModel = Instantiate(btnPrefab, content);
            btnObj.Add(empModel);
        }
    }

    public void OnValueChanged(bool value)
    {
        for (int i = 0; i < empType.Count; i++)
        {
            if (empType[i].isOn)
            {
                selectedEmpType = (Employee.designationType)i;
                FindEmployees(selectedEmpType);
                Debug.Log("OnValueChanged :::   " + selectedEmpType);

            }
        }
    }

    void FindEmployees(Employee.designationType empType)
    {
        selectedEmp = getData.empList.FindAll(x => x.designation == empType);
        //Debug.Log("count : " + selectedEmployees.Count);
        ShowEmployeeList();
    }

    public void ShowEmployeeList()
    {
        if (selectedEmp.Count > btnObj.Count)
        {
            GenerateEmployeeObjs(selectedEmp.Count - btnObj.Count);
        }
        int i = 0;
        foreach (EmployeeBTNmodel emp in btnObj)
        {
            if (i > selectedEmp.Count - 1)
            {
                emp.gameObject.SetActive(false);

            }
            else
            {
                emp.gameObject.SetActive(true);
                emp.SetButtonName(selectedEmp[i]);

            }
            i++;
        }
    }
    public void GoToRegisterScreen()
    {
        ScreenScript.Instance.registerScreen.SetActive(true);
        ScreenScript.Instance.empDataScreen.SetActive(false);
        ScreenScript.Instance.homeScreen.SetActive(false);

    }
}
