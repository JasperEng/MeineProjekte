(()=>{"use strict";async function t(){const t=(e=0,n=800,Math.floor(Math.random()*(n-e)+e));var e,n;let r=await fetch("https://pokeapi.co/api/v2/pokemon/"+t);return(await r.json()).sprites.front_default}function e(t){t.classList.contains("show")?t.classList.remove("show"):t.classList.add("show")}function n(){const t=Date.now();let e=document.querySelector(".timer-box .time");return e.innerHTML="00:00:00",setInterval((()=>{e.innerHTML=function(t){let e=t/36e5,n=Math.floor(e),r=60*(e-n),o=Math.floor(r),c=60*(r-o),a=Math.floor(c);return n=n.toString().padStart(2,"0"),o=o.toString().padStart(2,"0"),a=a.toString().padStart(2,"0"),`${n}:${o}:${a}`}(Date.now()-t)}),1e3)}async function r(r){const o=document.querySelector("#game-container .container");let c=2*r,a=await async function(e){let n=[];for(let r=0;r<e;r++){let e="",o={};e=await t(),o.id=r,o.url=e,n.push(o)}return n=[...n,...n],n.sort((()=>Math.random()-.5))}(r);for(o.innerHTML="";c>0;)o.innerHTML+=`<div class="card" data-id="${a[c-1].id}">\n            <div class="shadow"></div>\n            <div class="inner-card">\n                <div class="front-card"></div>\n                <div class="back-card">\n                    <img src="${a[c---1].url}">\n                </div>\n            </div>\n        </div>`;!function(t){const r=document.querySelectorAll(".card");let o=0,c="",a="",i=!0,s=t,l=!1,d=null;r.forEach((function(t){t.addEventListener("click",(function(){let t;if("true"!=this.dataset.done&&a!=this&&1==i)if(t=this.querySelector(".inner-card"),t.classList.add("clicked"),2!=++o)c=this.dataset.id,a=this;else if(o=0,i=!1,this.dataset.id===c){if(this.dataset.done="true",a.dataset.done="true",s-=1,setTimeout((()=>{this.querySelector(".shadow").style.transform="scale(1)",a.querySelector(".shadow").style.transform="scale(1)",i=!0}),0),0===s){const t=document.querySelector("#win-box");clearInterval(d),setTimeout((()=>{e(t)}),500)}}else{let t=this;setTimeout((()=>{t.querySelector(".inner-card").classList.remove("clicked"),a.querySelector(".inner-card").classList.remove("clicked"),i=!0}),500)}l||(d=n(),l=!0)}))}))}(r)}!async function(){const t=document.querySelector("#loading"),n=document.querySelector(".btn-start"),o=document.querySelector(".attention-text");let c=6;const a=document.querySelector("select"),i=document.querySelector("#levels");a.addEventListener("change",(function(){c=1*this.value})),n.addEventListener("click",(async()=>{!function(){const t=document.querySelector(".btn-start"),n=document.querySelector(".timer");let r=document.querySelector(".time");r="",e(t),e(n)}(),function(t){const e=document.querySelector("#game-container .container"),n=2*t/3;e.style.gridTemplateColumns=`repeat(${n}, 1fr)`,e.style.gridTemplateRows="repeat(3, 1fr)"}(c),e(i),e(t),await r(c),e(t)})),o.addEventListener("click",(()=>{window.location.reload()}))}()})();