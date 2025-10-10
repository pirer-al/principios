package com.example.employee2

class HourReporter {
    fun reportHours(employee: Employee2) {
        val regHours = regularHours(employee)
        println("Employee ${employee.name} has worked $regHours hours")
    }

    private fun regularHours(employee: Employee2) : Int {
        return if (employee.hoursWorked > 40) 40 else employee.hoursWorked
    }
}