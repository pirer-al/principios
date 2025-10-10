from Descuento import Descuento

class DescuentoClienteFrecuente(Descuento):
    def aplicar(self, precio):
        return precio * 0.8