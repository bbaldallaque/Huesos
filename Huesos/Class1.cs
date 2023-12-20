
using System;

namespace Huesos
{

    class EsqueletoHumano 
    {
        private string[] huesos;

        public EsqueletoHumano()
        {
            NombreHuesos();
        }

        private void NombreHuesos()
        {
            huesos = new string[206];

            huesos[0] = "Frontal";
            huesos[1] = "Occipital";
            huesos[2] = "Parietal izquierdo";
            huesos[3] = "Parietal derecho";
            huesos[4] = "Temporal izquierdo";
            huesos[5] = "Temporal derecho";
            huesos[6] = "Esfenoides";
            huesos[7] = "Etmoides";
            huesos[8] = "Maxilar inferior o mandíbula";
            huesos[9] = "Maxilar superior izquierdo";
            huesos[10] = " 







                `   



               huesos[2]   8 .
                 huesos[2] 9 .
                huesos[2]  10 .
               huesos[2]   11 Maxilar superior derecho.
                huesos[2]  12 Palatino izquierdo.
                huesos[2] 13 Palatino derecho.
                huesos[2]  14 Malar o cigomático izquierdo.
                15 Malar o cigomático derecho.
                16 Nasal izquierdo.
                17 Nasal derecho.
                18 Unguis o lagrimal izquierdo.
                19 Unguis o lagrimal derecho.
                20 Vómer.
                21 Cornete nasal izquierdo.
                22 Cornete nasal derecho.
                23 Martillo izquierdo.
                24 Martillo derecho.
                25 Yunque izquierdo.
                26 Yunque derecho.
                27 Estribo izquierdo.
                28 Estribo derecho.
                29 Hioides.
                30 Vértebra cervical C1.Llamada Atlas.
                31 Vértebra cervical C2.Llamada Axis.
                32 Vértebra cervical C3.Llamada C3.
                33 Vétrebra cervical C4.Llamada C4.
                34 Vértebra cervical C5.Llamada C5.
                35 Vértebra cervical C6.Llamada C6.
                36 Vertebra cervical C7.Llamada Prominente.
                37 Vértebra dorsal o torácica T1.Llamada T1
                38 Vértebra dorsal o torácica T2.Llamada T2
                39 Vértebra dorsal o torácica T3.Llamada T3
                40 Vértebra dorsal o torácica T4.Llamada T4
                41 Vértebra dorsal o torácica T5.Llamada T5
                42 Vértebra dorsal o torácica T6.Llamada T6
                43 Vértebra dorsal o torácica T7.Llamada T7
                44 Vértebra dorsal o torácica T8.Llamada T8
                45 Vértebra dorsal o torácica T9.Llamada T9
                46 Vértebra dorsal o torácica T10.Llamada T10.
                47 Vértebra dorsal o torácica T11.Llamada T11.
                48 Vértebra dorsal o torácica T12.Llamada T12.
                49 Vértebra Lumbar L1.Llamada L1.
                50 Vértebra Lumbar L2.Llamada L2.
                51 Vértebra Lumbar L3.Llamada L3.
                52 Vértebra Lumbar L4.Llamada L4.
                53 Vértebra Lumbar L5.Llamada L5.
                54 Sacro formado por 5 vértebras soldadas
                55 Coxis formado por 4 ó 5 vértebaras fusionadas.Caja torácica o tórax
                56 Esternon.
                57 Costilla verdedera izquierda unida a la vértebra T1 y esternón.
                58 Costilla verdedera derecha unida a la vértebra T1 y esternón.
                59 Costilla verdedera izquierda unida a la vértebra T2 y esternón.
                60 Costilla verdedera derecha unida a la vértebra T2 y esternón.
                61 Costilla verdedera izquierda unida a la vértebra T3 y esternón.
                62 Costilla verdedera derecha unida a la vértebra T3 y esternón.
                63 Costilla verdedera izquierda unida a la vértebra T4 y esternón.
                64 Costilla verdedera derecha unida a la vértebra T4 y esternón.
                65 Costilla verdedera izquierda unida a la vértebra T5 y esternón.
                66 Costilla verdedera derecha unida a la vértebra T5 y esternón.
                67 Costilla verdedera izquierda unida a la vértebra T6 y esternón.
                68 Costilla verdedera derecha unida a la vértebra T6 y esternón.
                69 Costilla verdedera izquierda unida a la vértebra T7 y esternón.
                70 Costilla verdedera derecha unida a la vértebra T7 y esternón.
                71 Costilla falsa izquierda unida a la vértebra T8 y la anterior costilla.
                72 Costilla falsa derecha unida a la vértebra T8 y la anterior costilla.
                73 Costilla falsa izquierda unida a la vértebra T9 y la anterior costilla.
                74 Costilla falsa derecha unida a la vértebra T9 y la anterior costilla.
                75 Costilla falsa izquierda unida a la vértebra T10 y la anterior costilla.
                76 Costilla falsa derecha unida a la vértebra T10 y la anterior costilla.
                77 Costilla falsa flotante izquierda unida a la vértebra T11.
                78 Costilla falsa flotante derecha unida a la vértebra T11.
                79 Costilla falsa flotante izquierda unida a la vértebra T12.
                80 Costilla falsa flotante derecha unida a la vértebra T12.Arco pectoral y manos
                81 Omóplato o Escápula izquierdo.
                82 Omóplato o Escápula derecho.
                83 Clavicula izquierda.
                84 Clavicula derecha.
                85 Húmero izquierdo.
                86 Húmero derecho.
                87 Cúbito o Ulna izquierdo.
                88 Cúbito o Ulna derecho.
                89 Radio izquierdo.
                90 Radio derecho.
                91 Escafoides izquierdo.
                92 Escafoides derecho.
                93 Semilunar izquierdo.
                94 Semilunar derecho.
                95 Piramidal izquierdo.
                96 Piramidal derecho.
                97 Pisiforme izquierdo.
                98 Pisiforme derecho.
                99 Ganchoso izquierdo.
                100 Ganchoso derecho.
                101 Grande izquierdo.
                102 Grande derecho.
                103 Trapezoide izquierdo.
                104 Trapezoide derecho.
                105 Trapecio izquierdo.
                106 Trapecio derecho.
                107 Metacarpio 1 dedo pulgar izquierdo.
                108 Metacarpio 1 dedo pulgar derecho.
                109 Falange 1 del dedo pulgar izquierdo.
                110 Falange 1 del dedo pulgar derecho.
                111 Falange 2 del dedo pulgar izquierdo.
                112 Falange 2 del dedo pulgar derecho.
                113 Metacarpio 2 dedo índice izquierdo.
                114 Metacarpio 2 dedo índice derecho.
                115 Falange 1 del dedo índice izquierdo.
                116 Falange 1 del dedo índice derecho.
                117 Falange 2 del dedo índice izquierdo.
                118 Falange 2 del dedo índice derecho.
                119 Falange 3 del dedo índice izquierdo.
                120 Falange 3 del dedo índice derecho.
                121 Metacarpio 3 dedo corazón izquierdo.
                122 Metacarpio 3 dedo corazón derecho.
                123 Falange 1 del dedo corazón izquierdo
                124 Falange 1 del dedo corazón derecho.
                125 Falange 2 del dedo corazón izquierdo.
                126 Falange 2 del dedo corazón derecho.
                127 Falange 3 del dedo corazón izquierdo.
                128 Falange 3 del dedo corazón derecho.
                129 Metacarpio 4 dedo anular izquierdo.
                130 Metacarpio 4 dedo anular derecho.
                131 Falange 1 del dedo anular izquierdo.
                132 Falange 1 del dedoanular derecho.
                133 Falange 2 del dedo anular izquierdo.
                134 Falange 2 del dedo anular derecho.
                135 Falange 3 del dedo anular izquierdo.
                136 Falange 3 del dedo anular derecho.
                137 Metacarpio 5 dedo meñique izquierdo.
                138 Metacarpio 5 dedo meñique derecho.
                139 Falange 1 del dedo meñique izquierdo.
                140 Falange 1 del dedo meñique derecho.
                141 Falange 2 del dedo meñique izquierdo.
                142 Falange 2 del dedo meñique derecho.
                143 Falange 3 del dedo meñique izquierdo.
                144 Falange 3 del dedo meñique derecho.Zona lumbar y piernas
                145 Coxal izquierdo.
                146 Coxal derecho.
                147 Fémur izquierdo.
                148 Fémur derecho.
                149 Rótula izquierda.
                150 Rótula derecha.
                151 Tibia izquierda.
                152 Tibia derecha.
                153 Peroné izquierdo.
                154 Peroné derecho.
                155 Calcáneo izquierdo.
                156 Calcáneo derecho.
                157 Astrágalo izquierdo.
                158 Astrágalo derecho.
                159 Cuboides izquierdo.
                160 Cuboides derecho.
                161 Escafoides izquierdo.
                162 Escafoides derecho.
                163 Cuneiformes 1 izquierdo.
                164 Cuneiformes 1 derecho.
                165 Cuneiformes 2 izquierdo.
                166 Cuneiformes2 derecho.
                167 Cuneiformes 3 izquierdo.
                168 Cuneiformes 3 derecho.
                169 Metatarsiano 1 dedo 1 izquierdo.
                170 Metatarsiano 1 dedo 1 derecho.
                171 Falange 1 del dedo 1 izquierdo.
                172 Falange 1 del dedo 1 derecho.
                173 Falange 2 del dedo 1 izquierdo.
                174 Falange 2 del dedo 1 derecho.
                175 Metatarsiano 2 dedo 2 izquierdo.
                176 Metatarsiano 2 dedo 2 derecho.
                177 Falange 1 del dedo 2 izquierdo.
                178 Falange 1 del dedo 2 derecho.
                179 Falange 2 del dedo 2 izquierdo.
                180 Falange 2 del dedo 2 derecho.
                181 Falange 3 del dedo 2 izquierdo.
                182 Falange 3 del dedo 2 derecho.
                183 Metatarsiano3 dedo 3 izquierdo.
                184 Metatarsiano3 dedo 3 derecho.
                185 Falange 1 del dedo 3 izquierdo.
                186 Falange 1 del dedo 3 derecho.
                187 Falange 2 del dedo 3 izquierdo.
                188 Falange 2 del dedo 3 derecho.
                189 Falange 3 del dedo 3 izquierdo.
                190 Falange 3 del dedo 3 derecho.
                191 Metatarsiano4 dedo 4 izquierdo.
                192 Metatarsiano4 dedo 4 derecho.
                193 Falange 1 del dedo 4 izquierdo.
                194 Falange 1 del dedo 4 derecho.
                195 Falange 2 del dedo 4 izquierdo.
                196 Falange 2 del dedo 4 derecho.
                197 Falange 3 del dedo 4 izquierdo.
                198 Falange 3 del dedo 4 derecho.
                199 Metatarsiano5 dedo 5 izquierdo.
                200 Metatarsiano5 dedo 5 derecho.
                201 Falange 1 del dedo 5 izquierdo.
                202 Falange 1 del dedo 5 derecho.
                203 Falange 2 del dedo 5 izquierdo.
                204 Falange 2 del dedo 5 derecho.
                205 Falange 3 del dedo 5 izquierdo.
                206 Falange 3 del dedo 5 derecho.
        }

        public class Atributos
        {
            public string Nombre { get; set; }

            public decimal Peso { get; set; }

            public decimal Densidad { get; set; }

            public decimal Longitud { get; set; }

            public decimal Diametro { get; set; }
        }
    }
    //class Esqueleto
    //{
    //    private string[] nombreHuesosCuerpoHumano;

    //}
    //public Esqueleto()
    //{
    //    NombreHuesos();
    //}

    //private void NombreHuesos()
    //{

    //}
}

/*
Pasos

1- Crear la clase hueso 
2- Campos de la clases hueso

 
 */