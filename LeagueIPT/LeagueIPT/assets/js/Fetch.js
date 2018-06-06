
function getChamps(name) {
    const url = "/api/champions/?name=" + name;
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
                console.log(respostaServidor);
                return respostaServidor.json();
            } else {
                return Promise.reject(new Error("Erro ao obter champion"));
            }
        });

}

function getHabilidades(champId) {
    var url = "/api/champions/" + champId +"/habilidades" ;
    return fetch(url, { headers: { Accept: "application/json" } })
        .then(function (respostaServidor) {
            if (respostaServidor.status === 200) {
                return respostaServidor.json();
            } else {
                return Promise.reject(new Error("Erro ao obter champion"));
            }
        });

}

function getSkins(champId) {
    var url = "/api/champions/" + champId +"/skins" ;
    return fetch(url, { headers: { Accept: "application/json" } })
        .then(function (respostaServidor) {
            if (respostaServidor.status === 200) {
                return respostaServidor.json();
            } else {
                return Promise.reject(new Error("Erro ao obter champion"));
            }
        });

}