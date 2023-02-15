.code
ofset = 0 ;Zmienne poczatkowe
petla1 = 4
petla2 = 8
buffer = 32
endx = 40
endy = 48
depth = 56
tolerancja = 64
R = 72
G = 80
B = 88

Process PROC
start:
        mov     DWORD PTR [rsp+32], r9d         ;za³adowanie zmiennych ze stosu
        mov     DWORD PTR [rsp+24], r8d         ;za³adowanie zmiennych ze stosu
        mov     DWORD PTR [rsp+16], edx         ;za³adowanie zmiennych ze stosu
        mov     QWORD PTR [rsp+8], rcx          ;za³adowanie zmiennych ze stosu
        sub     rsp, 24                         ;powrot na gore stosu
        mov     DWORD PTR petla2[rsp], 0        ;ustawienie poczatku petli
        jmp     SHORT konprog                   ;skok
incpet2:
        mov     eax, DWORD PTR petla2[rsp]      ;inkrementacja petli
        inc     eax                             ;inkrementacja petli
        mov     DWORD PTR petla2[rsp], eax      ;inkrementacja petli
konprog:
        mov     eax, DWORD PTR endx[rsp]        ;przeniesienie ednx do eax
        cmp     DWORD PTR petla2[rsp], eax      ;ustawienie flag
        jge     koniec                          ;sprawdzenie czy petla2 sie skonczyla jesli tak to skok do warunku
        mov     DWORD PTR petla1[rsp], 0        ;zerowanie petli 1 jesli petla druga sie skonczy
        jmp     SHORT warunek                   ;skok
incpet1:
        mov     eax, DWORD PTR petla1[rsp]      ;inkrementacja petli
        inc     eax                             ;inkrementacja petli
        mov     DWORD PTR petla1[rsp], eax      ;inkrementacja petli
warunek:
        mov     eax, DWORD PTR endy[rsp]        ;przeniesienie do eax endy
        cmp     DWORD PTR petla1[rsp], eax      ;ustawienie flag(usuwanie)
        jge     incpet2                         ;skok, jeœli wiêksze lub równe
        mov     eax, DWORD PTR petla1[rsp]      ;obliczenie ofsetu
        imul    eax, DWORD PTR endx[rsp]        ;obliczenie ofsetu
        add     eax, DWORD PTR petla2[rsp]      ;obliczenie ofsetu
        imul    eax, DWORD PTR depth[rsp]       ;obliczenie ofsetu
        mov     DWORD PTR ofset[rsp], eax       ;przypisanie ofsetu
        add     eax, 2                          ;podwojna inkremetacja
        cdqe                                    ;dword->qword rax
        mov     rcx, QWORD PTR buffer[rsp]      ;przeniesienie buffora do rejestru rcx
        cvtsi2ss xmm0, DWORD PTR [rcx+rax*4]    ;konwertowanie dworda na wartosc skalarna
        addss   xmm0, DWORD PTR tolerancja[rsp] ;dodawanie wartosci skalarnej
        cvtsi2ss xmm1, DWORD PTR R[rsp]         ;konwertowanie dworda na wartosc skalarnav
        comiss  xmm0, xmm1                      ;porownanie i ustawienie flag
        jbe     incpet1                         ;skok, jeœli mniejsze lub równe
        mov     eax, DWORD PTR ofset[rsp]       ;przeniesiete ofsetu do eax
        add     eax, 2                          ;podwojna inkremetacja
        mov     rcx, QWORD PTR buffer[rsp]      ;przeniesienie buffora do rejestru rcx
        cvtsi2ss xmm0, DWORD PTR [rcx+rax*4]    ;konwertowanie dworda na wartosc skalarna
        subss   xmm0, DWORD PTR tolerancja[rsp] ;odejmowanie wartosci skalarnej
        cvtsi2ss xmm1, DWORD PTR R[rsp]         ;konwertowanie dworda na wartosc skalarna
        comiss  xmm1, xmm0                      ;porownanie i ustawienie flag
        jbe     incpet1                         ;skok, jeœli mniejsze lub równe
        mov     eax, DWORD PTR ofset[rsp]       ;przeniesiete ofsetu do eax
        inc     eax                             ;inkremetacja
        mov     rcx, QWORD PTR buffer[rsp]      ;przeniesienie buffora do rejestru rcx
        cvtsi2ss xmm0, DWORD PTR [rcx+rax*4]    ;konwertowanie dworda na wartosc skalarna
        addss   xmm0, DWORD PTR tolerancja[rsp] ;dodawanie wartosci skalarnej
        cvtsi2ss xmm1, DWORD PTR G[rsp]         ;konwertowanie dworda na wartosc skalarna
        comiss  xmm0, xmm1                      ;porownanie i ustawienie flag
        jbe     incpet1                         ;skok, jeœli mniejsze lub równe
        mov     eax, DWORD PTR ofset[rsp]       ;przeniesiete ofsetu do eax
        inc     eax                             ;podwojna inkremetacja
        mov     rcx, QWORD PTR buffer[rsp]      ;przeniesienie buffora do rejestru rcx
        cvtsi2ss xmm0, DWORD PTR [rcx+rax*4]    ;konwertowanie dworda na wartosc skalarna
        subss   xmm0, DWORD PTR tolerancja[rsp] ;odejmowanie wartosci skalarnej
        cvtsi2ss xmm1, DWORD PTR G[rsp]         ;konwertowanie dworda na wartosc skalarna
        comiss  xmm1, xmm0                      ;porownanie i ustawienie flag
        jbe     incpet1                         ;skok, jeœli mniejsze lub równe
        mov     eax, DWORD PTR ofset[rsp]       ;przeniesiete ofsetu do eax
        mov     rcx, QWORD PTR buffer[rsp]      ;przeniesienie buffora do rejestru rcx
        cvtsi2ss xmm0, DWORD PTR [rcx+rax*4]    ;konwertowanie dworda na wartosc skalarna
        addss   xmm0, DWORD PTR tolerancja[rsp] ;dodawanie wartosci skalarnej
        cvtsi2ss xmm1, DWORD PTR B[rsp]         ;konwertowanie dworda na wartosc skalarna
        comiss  xmm0, xmm1                      ;porownanie i ustawienie flag
        jbe     incpet1                         ;skok, jeœli mniejsze lub równe
        mov     eax, DWORD PTR ofset[rsp]       ;przeniesiete ofsetu do eax
        mov     rcx, QWORD PTR buffer[rsp]      ;przeniesienie buffora do rejestru rcx
        cvtsi2ss xmm0, DWORD PTR [rcx+rax*4]    ;konwertowanie dworda na wartosc skalarna
        subss   xmm0, DWORD PTR tolerancja[rsp] ;odejmowanie wartosci skalarnej
        cvtsi2ss xmm1, DWORD PTR B[rsp]         ;konwertowanie dworda na wartosc skalarna
        comiss  xmm1, xmm0                      ;porownanie i ustawienie flag
        jbe     incpet1                         ;skok, jeœli mniejsze lub równe
        mov     eax, DWORD PTR ofset[rsp]       ;zmiana kanalu alpha
        add     eax, 3                          ;potrojna inkremetacja
        mov     rcx, QWORD PTR buffer[rsp]      ;przeniesienie buffora do rejestru rcx
        mov     DWORD PTR [rcx+rax*4], 0        ;zerowanie rejestru
        jmp     incpet1                         ;skok
koniec:                                         ;etykieta koniec
        add     rsp, 24                         ;dodanie do rsp
        ret     0                               ;koniec programu
Process ENDP               ; Process
END