from Descuento import Descuento

class DescuentoNavidad(Descuento):
    def aplicar(self, precio):
        return precio * 0.8