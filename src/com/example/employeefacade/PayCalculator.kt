package com.example.employeefacade

class PayCalculator {
    fun calculatePay(employeeData: EmployeeData) : Double {
        val regHours = regularHours(employeeData)
        val nonOrdinaryHours = (employeeData.hoursWorked - regHours).coerceAtLeast(0)
        return (regHours * employeeData.hourlyRate) +
                (nonOrdinaryHours * employeeData.hourlyRate * 1.5)
    }

    fun regularHours(employeeData: EmployeeData): Int {
        return if (employeeData.hoursWorked > 40) 40 else employeeData.hoursWorked
    }
}