# CorralonQuoter

Herramienta de escritorio en C# para agilizar la generación de presupuestos
en una ferretería/corralón, pensada para reducir el tiempo de respuesta a
consultas de venta online (WhatsApp, Facebook, Marketplace).

## Contexto del problema
El negocio recibe consultas de precios por WhatsApp y Facebook, pero el
armado manual de presupuestos genera demoras que derivan en pérdida de
ventas. Esta herramienta permite buscar productos, armar un presupuesto
con cantidades y generar un texto listo para enviar por WhatsApp.

## Estado actual
🚧 En desarrollo — v0.1 (consola, datos de ejemplo)

## Roadmap
- [ ] v0.1: catálogo en memoria, búsqueda, generación de texto de presupuesto (consola)
- [ ] v0.2: lógica completa y casos de borde
- [ ] v1: interfaz WinForms
- [ ] v2: importación desde Excel (ClosedXML), exportación a PDF

## Stack
C# / .NET · WinForms (v1+) · ClosedXML (v2+)