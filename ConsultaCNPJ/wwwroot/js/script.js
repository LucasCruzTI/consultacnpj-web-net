async function consultarCNPJ() {
    const cnpjInput = document.getElementById('cnpjInput');
    const resultadoDiv = document.getElementById('resultado');

    const cnpj = cnpjInput.value.replace(/[^\d]+/g, ''); // Remove caracteres não numéricos

    if (cnpj.length !== 14) {
        alert('Por favor, insira um CNPJ válido.');
        return;
    }

    try {

        $.ajax({
            url: "Grupo7TemaCNPJ/ConsultarCPNJ?cnpj=" + cnpj,
            type: "GET",
            success: function (resultado) {

                $("#divResultado").removeClass("d-none");
                $("#resultado").html(resultado);
            }
        });

    } catch (error) {
        console.error('Erro na requisição:', error);
        resultadoDiv.innerHTML = `<p style="color: red;">Erro ao consultar CNPJ. Tente novamente mais tarde.</p>`;
    }
}

//function setInputFilter(textbox, inputFilter, errMsg) {
//    ["input", "keydown", "keyup", "mousedown", "mouseup", "select", "contextmenu", "drop", "focusout"].forEach(function (event) {
//        textbox.addEventListener(event, function (e) {
//            if (inputFilter(this.value)) {
//                // Accepted value
//                if (["keydown", "mousedown", "focusout"].indexOf(e.type) >= 0) {
//                    this.classList.remove("input-error");
//                    this.setCustomValidity("");
//                }
//                this.oldValue = this.value;
//                this.oldSelectionStart = this.selectionStart;
//                this.oldSelectionEnd = this.selectionEnd;
//            } else if (this.hasOwnProperty("oldValue")) {
//                // Rejected value - restore the previous one
//                this.classList.add("input-error");
//                this.setCustomValidity(errMsg);
//                this.reportValidity();
//                this.value = this.oldValue;
//                this.setSelectionRange(this.oldSelectionStart, this.oldSelectionEnd);
//            } else {
//                // Rejected value - nothing to restore
//                this.value = "";
//            }
//        });
//    });
//}

//setInputFilter(document.getElementById("cnpjInput"), function (value) {
//    return /^-?\d*$/.test(value);
//}, "Informe somente números");