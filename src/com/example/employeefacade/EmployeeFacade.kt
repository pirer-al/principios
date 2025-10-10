package com.example.employeefacade

class EmployeeFacade {
    private val employeeSaver = EmployeeSaver()
    private val hourReporter = HourReporter()
    private val payCalculator = PayCalculator()

    fun calculatePay(employeeData : EmployeeData) {
        employeeSaver.saveEmployee(employeeData)
    }

    fun hourReporter(employeeData: EmployeeData) {
        hourReporter.reportHours(employeeData)
    }

    fun payCalculator(employeeData: EmployeeData) {
        payCalculator.calculatePay(employeeData)
    }
}