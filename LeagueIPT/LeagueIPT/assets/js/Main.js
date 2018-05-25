document.addEventListener("DOMContentLoaded",
    function main() {
        function init() {
            ecrachamps();
        }

        init();

        /**
         *
         *
         * @param {Array<{ id: string, Pic: string }>} champs
         */
        function mostrarChamps(champs) {
            for (let champ of champs) {

                var mainDiv = document.querySelector("#conteudo");

                var a = document.createElement("a");
                a.setAttribute("style", "height: 80px; width:80px;margin-right:12px;margin-left:12px;margin-bottom:25px;");

                var img = document.createElement("img");
                img.setAttribute("style", "width:80px");
                img.setAttribute("src", champ.Pic);

                a.appendChild(img);
                mainDiv.appendChild(a);
            }

        }

        async function ecrachamps() {
            try {
                let batatas = await getChamps();

                mostrarChamps(batatas);
            } catch(erro){
                console.error(erro);
            }
        }
    });

