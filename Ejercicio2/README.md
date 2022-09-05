# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías
### Programación II

### Sistema de consultas médicas

Como desarrolladores de software, se nos pide hacer el mantenimiento de un sistema de gestión médica, especifícamente se nos pide que hagamos mantenimiento de la funcionalidad de coordinación de consultas. Para ello debemos tener en cuenta que:
1. Se podrían agregar otros datos del paciente como por ejemplo su edad.
2. Se podrían agregar otros datos al Doctor como por ejemplo su especialidad.
3. La consulta debe tener un identificador único
4. Cada dato que se ingrese al sistema debe ser válidado.

Para el ejercicio se pide

#### ✍ Parte 1
**Criticar el código dado en base a patrónes y principios**
El código se podía dividir en tres clases (o más en caso de querer agregar otras funcionalidades), ya que la información personal del paciente y doctor son independientes de la cita en sí. Dividiendolas en clases facilitaría el tomar a los pacientes y doctores como objetos y poder ingresarlos tantas veces sea necesario, en lugar de pasar por parametro toda la información, y en algunos casos tener que respetirla. 

#### 🧐 Parte 2
**Realizar las CRC correspondientes.**
Se encuentra en la carpeta /ejercicio2/crc

#### 👩‍💻 Parte 3
**Aplique patrónes/principios según su crítica.**

