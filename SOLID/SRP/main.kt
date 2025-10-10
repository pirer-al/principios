import com.example.employee1.*
import com.example.employee2.*
import com.example.employeefacade.EmployeeData
import com.example.employeefacade.EmployeeFacade

fun main() {
    // Non SRP principle
    val newemployee = Employee1(
        1,
        "Pedro Alonso",
        38,
        50.0
    )

    println(newemployee.calculatePay())

    // SRP principle applied

    val newemployee2 = Employee2(
        id = 2,
        name = "Fernando Enriquez",
        hoursWorked = 36,
        hourlyRate = 55.0
    )
    val employeeSaver = EmployeeSaver()
    val hourReporter = HourReporter()
    val payCalculator = PayCalculator()

    println(payCalculator.calculatePay(newemployee2))

    // Facade Pattern Applied
    val newemployee3 = EmployeeData(
        id = 3,
        name = "Magdielito",
        hoursWorked = 30,
        hourlyRate = 60.0
    )

    val employefacade = EmployeeFacade()

    employefacade.calculatePay(newemployee3)

}
