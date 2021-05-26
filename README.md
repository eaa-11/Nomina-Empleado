# Nomina de empleados
Aplicacion que manejara las operaciones de nomina de empleados para determinada
empresa.

CREACION DE EMPLEADOS
La aplicacion debe permitir la creación de registros de empleados.

CALCULO DE NOMINA
En esta funcionalidad, la empresa desea calcular el salario a cobrar del empleado. La
logica sugerente sería el salario - los descuentos.
Los descuentos son:
- AFP: 2.87% del salario del empleado
- SFS: 3.04% del salario del empleado
Otros descuentos (estos descuentos son opcionales)
- La empresa tiene una cooperativa.
- Plan de farmacia.
- Tambien tiene un beneficio de plan funerario.

Estos planes y/o servicios son opcionales. Cada empleado tiene libertad de eleccion
para tenerlos o no.
La idea de estas entidades (cooperativa y farmacia y plan funerario) es realizar
descuentos al salario del empleado, para los fines pertinentes (ahorros para prestamos, compra de medicamentos a credito y ahorro para tener facilidades en caso de que fallezca un familiar)
Se requiere:
Que tan pronto el empleado cobre, estos servicios realicen el respectivo descuento, en caso que el empleado este afiliado a ellos.
En el caso de la cooperativa, el descuento siempre será una proporcion (un porcentaje) del salario percibido por el empleado. (Determine usted ese porcentaje). Debe realizar el calculo y mostrar en un mensaje el valor calculado.
En el caso de la farmacia, implemente una lógica para determinar si el empleado
realizó consumos en la farmacia. En caso de ser asi, divida el monto de ese consumo
entre 2 y el resultado sera el monto a descontar. Debe realizar el calculo y mostrar
en un mensaje el valor calculado.
En el caso del plan funerario, este validará si el salario del empleado está por encima
de un tope minimo(determine usted ese monto minimo). De ser asi, pues le aplica el
descuento de un monto fijo (determine usted el monto). En caso contrario, no aplica
nada. Debe mostrar en un mensaje el valor calculado.
Aplique el patron de diseño observer para lograr este comportamiento.
Diseñe una interfaz de usuario que permita:
- La creacion del empleado
- La inscripcion / cancelacion de los planes (cooperativa , farmacia y plan
funerario)
- El registro del consumo de farmacia
- El calculo de la nomina.
o Cuando se realice el calculo de la nomina, debe realizar el calculo a
todos los empleados registrados y mostrar lo siguiente
o Nombre - Salario Bruto- El valor de cada descuento (0 para los
descuentos que no apliquen) -Salario Neto
