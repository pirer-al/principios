package com.example.employee1

class Employee1 (
    protected val id: Int,
    protected val name: String,
    protected val hoursWorked: Int,
    protected val hourlyRate: Double
) {
    fun calculatePay(): Double {
        val regHours = regularHours()
        return regHours * hourlyRate
    }

    fun reportHours(): String {
        val regHours = regularHours()
        return "Employee %name has worked $regHours hours"
    }

    fun saveData() {
        println("Saving employee $name to database...")
    }

    private fun regularHours(): Int {
        return if (hoursWorked > 40) 40 else hoursWorked
    }
}