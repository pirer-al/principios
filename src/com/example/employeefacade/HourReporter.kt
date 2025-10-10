package com.example.employeefacade

class HourReporter {
    fun reportHours(employeeData: EmployeeData) : String {
        val regHours = regularHours(employeeData)
        val nonOrdinaryHours = (employeeData.hoursWorked - regHours).coerceAtLeast(0)
        return "Employee ${employeeData.name} has worked $regHours hours and $nonOrdinaryHours non-ordinary hours"
    }

    fun regularHours(employeeData: EmployeeData): Int {
        return if (employeeData.hoursWorked > 40) 40 else employeeData.hoursWorked
    }
}