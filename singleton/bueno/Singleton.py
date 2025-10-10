from datetime import date


class Logger:
    _instance = None
    _logs:list[str] = []

    def __new__(cls):
        if cls._instance is None:
            cls._instance = super().__new__(cls)
        return cls._instance

    def log(self, mensaje):
        self._logs.append(f"{date.today()}: {mensaje}")

    def show_logs(self):
        return self._logs
    
class Usuario:
    def __init__(self, usuario_id, nombre):
        self.id = usuario_id
        self.nombre = nombre
        self.pedidos:list["Pedido"] = []

    def registrar(self):
        logger = Logger()
        logger.log(f"Usuario registrado: {self.nombre}")

    def agregar_pedido(self, pedido : "Pedido"):
        logger = Logger()
        logger.log(f"Pedido agregado: {pedido.id} por {self.nombre}")
        self.pedidos.append(pedido)

    def mostrar_pedidos(self):
        return self.pedidos

class Pedido:
    def __init__(self, pedido_id, fecha, monto):
        self.id = pedido_id
        self.fecha =  fecha
        self.monto = monto
        self.estado = "Pendiente"

    def procesar(self):
        self.estado = "En proceso"
        logger = Logger()
        logger.log(f"El pedido {self.id} se ha procesado")
    
    def cancelar(self):
        self.estado = "Cancelado"
        logger = Logger()
        logger.log(f"El pedido {self.id} se ha cancelado")

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
    
    for log in logger.show_logs():
        print(log)