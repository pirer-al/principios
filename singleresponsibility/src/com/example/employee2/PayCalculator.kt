package com.example.employee2

class PayCalculator {
    fun calculatePay(employee: Employee2) : Double {
        val regHours = regularHours(employee)
        return (employee.hoursWorked * regHours).toDouble()
    }

    private fun regularHours(employee: Employee2) : Int {
        return if (employee.hoursWorked > 40) 40 else employee.hoursWorked
    }
}