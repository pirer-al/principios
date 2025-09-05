# Source: https://usaco.guide/general/io

class Animal:
    def hablar (self):
        raise NotImplementedError

class Perro(Animal):
    def hablar(self): return "guau"

class Gato(Animal):
    def hablar(self): return "miau"

def saludar(animal):
    print(animal.hablar())

saludar(Perro())
saludar(Gato())
