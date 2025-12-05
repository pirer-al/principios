from datetime import date


class Logger:
    def __init__(self):
        self._logs:list[str] = []

    def log(self, mensaje):
        self._logs.append(f"{date.today()}: {mensaje}")

    def show_logs(self):
        return self._logs
    
class Usuario:
    def __init__(self, usuario_id, nombre):
        self.id = usuario_id
        self.nombre = nombre
        self.pedidos:list["Pedido"] = []
        self.logger = Logger()

    def registrar(self):
        self.logger.log(f"Usuario registrado: {self.nombre}")

    def agregar_pedido(self, pedido : "Pedido"):
        self.logger.log(f"Pedido agregado: {pedido.id} por {self.nombre}")
        self.pedidos.append(pedido)

    def mostrar_pedidos(self):
        return self.pedidos

class Pedido:
    def __init__(self, pedido_id, fecha, monto):
        self.id = pedido_id
        self.fecha =  fecha
        self.monto = monto
        self.estado = "Pendiente"
        self.logger = Logger()

    def procesar(self):
        self.estado = "En proceso"
        self.logger.log(f"El pedido {self.id} se ha procesado")
    
    def cancelar(self):
        self.estado = "Cancelado"
        self.logger.log(f"El pedido {self.id} se ha cancelado")

    def mostrar_detalle(self):
        return f"Pedido {self.id}: Fecha: {self.fecha}, Monto: {self.monto}, Estado: {self.estado}"

if __name__ == "__main__":
    usuario = Usuario(1, "Fernandinho")
    usuario.registrar()

    p1 = Pedido(101, date.today(), 44444)
    usuario.agregar_pedido(p1)
    p1.procesar()

    p2 = Pedido(102, date.today(), 55555)
    usuario.agregar_pedido(p2)
    p2.cancelar()

    print("Logs del sistema:")

    for pedido in usuario.mostrar_pedidos():
        print(pedido.mostrar_detalle())
    
    logger = Logger()
    
    for log in usuario.logger.show_logs():
        print(log)

    for log1 in p1.logger.show_logs():
        print(log1)
    
    for log2 in p2.logger.show_logs():
        print(log2)