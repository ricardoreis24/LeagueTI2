
function getChamps() {
    const url = "/api/champions/";
    return fetch(url, { headers: { Accept: "application/json" } })
        .then(function(resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter champs"));
            }
        });

}

function getDetalhes(champId) {
    var url = "/api/champions/" + champId +"/" ;
    return fetch(url, { headers: { Accept: "application/json" } })
        .then(function (respostaServidor) {
            if (respostaServidor.status === 200) {
                return respostaServidor.json();
            } else {
                return Promise.reject(new Error("Erro ao obter champion"));
            }
        });

}