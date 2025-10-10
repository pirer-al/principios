package com.example.animal

import kotlin.io.println
import java.lang.reflect.Type

class Pato (
    type: String,
    name: String,
    age: Int?,
    size: String
) : Animal(type, name, age), Volador {

    override fun fly() {
        println("El pato $name está volando")
    }

    override fun eat() {
        println("El pato $name está comiendo")
    }

    override fun talking() : String {
        return "El pato $name hace Cuac Cuac"
    }
}