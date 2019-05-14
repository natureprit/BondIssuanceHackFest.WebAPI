﻿using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BondIssuanceHackFest.WebAPI.Controllers
{
    public class BookRunner : ContractDeploymentMessage
    {
        public static string BYTECODE = "6080604052600a601c55601e601d55601e80556014601f55600a6020553480156200002957600080fd5b50604051620015393803806200153983398101806040526101608110156200005057600080fd5b81516020830151604084018051929491938201926401000000008111156200007757600080fd5b820160208101848111156200008b57600080fd5b8151640100000000811182820187101715620000a657600080fd5b50509291906020018051640100000000811115620000c357600080fd5b82016020810184811115620000d757600080fd5b8151640100000000811182820187101715620000f257600080fd5b505060208201516040830151606090930180519295919491926401000000008111156200011e57600080fd5b820160208101848111156200013257600080fd5b81516401000000008111828201871017156200014d57600080fd5b505092919060200180516401000000008111156200016a57600080fd5b820160208101848111156200017e57600080fd5b81516401000000008111828201871017156200019957600080fd5b505060208083015160408401516060909401518b51939650909450918a918a918a91620001cc916003918601906200038b565b508151620001e29060049060208501906200038b565b506005805460ff191660ff92909216919091179055506200020c905033620002ad602090811b901c565b601580546001600160a01b0319166001600160a01b038c169081179091556000908152600a6020908152604090912086516200024b928801906200038b565b50601680546001600160a01b038089166001600160a01b03199283161790925560178054928e16929091169190911790558351620002919060189060208701906200038b565b50601992909255601a55601b5550620004309650505050505050565b620002c8816006620002ff60201b6200100a1790919060201c565b6040516001600160a01b038216907f6ae172837ea30b801fbfcdd4108aa1d5bf8ff775444fd70256b44e6bf3dfc3f690600090a250565b6001600160a01b0381166200031357600080fd5b6200032582826200035560201b60201c565b156200033057600080fd5b6001600160a01b0316600090815260209190915260409020805460ff19166001179055565b60006001600160a01b0382166200036b57600080fd5b506001600160a01b03166000908152602091909152604090205460ff1690565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f10620003ce57805160ff1916838001178555620003fe565b82800160010185558215620003fe579182015b82811115620003fe578251825591602001919060010190620003e1565b506200040c92915062000410565b5090565b6200042d91905b808211156200040c576000815560010162000417565b90565b6110f980620004406000396000f3fe608060405234801561001057600080fd5b50600436106101215760003560e01c806395d89b41116100ad578063aa271e1a11610071578063aa271e1a14610397578063d39fec73146103bd578063dd62ed3e1461041f578063edd09bf81461044d578063efe8b25a1461047657610121565b806395d89b4114610309578063983b2d56146103115780639865027514610337578063a457c2d71461033f578063a9059cbb1461036b57610121565b8063313ce567116100f4578063313ce56714610233578063395093511461025157806340c10f191461027d57806370a08231146102a95780638f70585f146102cf57610121565b806306fdde0314610126578063095ea7b3146101a357806318160ddd146101e357806323b872dd146101fd575b600080fd5b61012e61047e565b6040805160208082528351818301528351919283929083019185019080838360005b83811015610168578181015183820152602001610150565b50505050905090810190601f1680156101955780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b6101cf600480360360408110156101b957600080fd5b506001600160a01b038135169060200135610514565b604080519115158252519081900360200190f35b6101eb610590565b60408051918252519081900360200190f35b6101cf6004803603606081101561021357600080fd5b506001600160a01b03813581169160208101359091169060400135610596565b61023b61065f565b6040805160ff9092168252519081900360200190f35b6101cf6004803603604081101561026757600080fd5b506001600160a01b038135169060200135610668565b6101cf6004803603604081101561029357600080fd5b506001600160a01b038135169060200135610716565b6101eb600480360360208110156102bf57600080fd5b50356001600160a01b031661073d565b610307600480360360808110156102e557600080fd5b506001600160a01b038135169060208101359060408101359060600135610758565b005b61012e610a48565b6103076004803603602081101561032757600080fd5b50356001600160a01b0316610aa9565b610307610ac7565b6101cf6004803603604081101561035557600080fd5b506001600160a01b038135169060200135610ad2565b6101cf6004803603604081101561038157600080fd5b506001600160a01b038135169060200135610b1b565b6101cf600480360360208110156103ad57600080fd5b50356001600160a01b0316610b28565b6103e3600480360360208110156103d357600080fd5b50356001600160a01b0316610b41565b604080516001600160a01b0396871681526020810195909552848101939093526060840191909152909216608082015290519081900360a00190f35b6101eb6004803603604081101561043557600080fd5b506001600160a01b0381358116916020013516610b7e565b6103076004803603606081101561046357600080fd5b5080359060208101359060400135610ba9565b6101eb610bc5565b60038054604080516020601f600260001961010060018816150201909516949094049384018190048102820181019092528281526060939092909183018282801561050a5780601f106104df5761010080835404028352916020019161050a565b820191906000526020600020905b8154815290600101906020018083116104ed57829003601f168201915b5050505050905090565b60006001600160a01b03831661052957600080fd5b3360008181526001602090815260408083206001600160a01b03881680855290835292819020869055805186815290519293927f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925929181900390910190a350600192915050565b60025490565b6001600160a01b03831660009081526001602090815260408083203384529091528120546105ca908363ffffffff610bcb16565b6001600160a01b03851660009081526001602090815260408083203384529091529020556105f9848484610be0565b6001600160a01b0384166000818152600160209081526040808320338085529083529281902054815190815290519293927f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925929181900390910190a35060019392505050565b60055460ff1690565b60006001600160a01b03831661067d57600080fd5b3360009081526001602090815260408083206001600160a01b03871684529091529020546106b1908363ffffffff610cab16565b3360008181526001602090815260408083206001600160a01b0389168085529083529281902085905580519485525191937f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925929081900390910190a350600192915050565b600061072133610b28565b61072a57600080fd5b6107348383610cc4565b50600192915050565b6001600160a01b031660009081526020819052604090205490565b6040805160a0810182526001600160a01b0386168082526020820186905291810184905260608101839052336080909101819052601080546001600160a01b031990811690931790556011859055601284905560138390556014805490921617905560195483108015906107ce5750601a548211155b15610a425733600081815260076020526040902060105481546001600160a01b03199081166001600160a01b039283161783556011546001840155601254600284015560135460038401556014546004909301805490911692821692909217909155838302600f55601654161461087957604051600160e51b62461bcd02815260040180806020018281038252602f81526020018061109f602f913960400191505060405180910390fd5b60175460408051600160e01b6370a0823102815233600482015290516001600160a01b03909216916370a0823191602480820192602092909190829003018186803b1580156108c757600080fd5b505afa1580156108db573d6000803e3d6000fd5b505050506040513d60208110156108f157600080fd5b5051600f541061094b5760408051600160e51b62461bcd02815260206004820152601460248201527f496e73756666696369656e742042616c616e6365000000000000000000000000604482015290519081900360640190fd5b601754601654600f5460408051600160e01b63a9059cbb0281526001600160a01b039384166004820152602481019290925251919092169163a9059cbb9160448083019260209291908290030181600087803b1580156109aa57600080fd5b505af11580156109be573d6000803e3d6000fd5b505050506040513d60208110156109d457600080fd5b5050336000908152600b6020526040902054610a4257600f54336000818152600b6020526040812092909255600c805460018101825592527fdf6966c971051c3d54ec59162606531493a51404a002842f56009d7e5cf4a8c790910180546001600160a01b03191690911790555b50505050565b60048054604080516020601f600260001961010060018816150201909516949094049384018190048102820181019092528281526060939092909183018282801561050a5780601f106104df5761010080835404028352916020019161050a565b610ab233610b28565b610abb57600080fd5b610ac481610d6c565b50565b610ad033610db4565b565b60006001600160a01b038316610ae757600080fd5b3360009081526001602090815260408083206001600160a01b03871684529091529020546106b1908363ffffffff610bcb16565b6000610734338484610be0565b6000610b3b60068363ffffffff610dfc16565b92915050565b6001600160a01b03908116600090815260076020526040902080546001820154600283015460038401546004909401549285169591949093921690565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205490565b6019839055601a829055601b819055610bc0610e31565b505050565b600d5490565b600082821115610bda57600080fd5b50900390565b6001600160a01b038216610bf357600080fd5b6001600160a01b038316600090815260208190526040902054610c1c908263ffffffff610bcb16565b6001600160a01b038085166000908152602081905260408082209390935590841681522054610c51908263ffffffff610cab16565b6001600160a01b038084166000818152602081815260409182902094909455805185815290519193928716927fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef92918290030190a3505050565b600082820183811015610cbd57600080fd5b9392505050565b6001600160a01b038216610cd757600080fd5b600254610cea908263ffffffff610cab16565b6002556001600160a01b038216600090815260208190526040902054610d16908263ffffffff610cab16565b6001600160a01b0383166000818152602081815260408083209490945583518581529351929391927fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9281900390910190a35050565b610d7d60068263ffffffff61100a16565b6040516001600160a01b038216907f6ae172837ea30b801fbfcdd4108aa1d5bf8ff775444fd70256b44e6bf3dfc3f690600090a250565b610dc560068263ffffffff61105616565b6040516001600160a01b038216907fe94479a9f7e1952cc78f2d6baab678adc1b772d936c6583def489e524cb6669290600090a250565b60006001600160a01b038216610e1157600080fd5b506001600160a01b03166000908152602091909152604090205460ff1690565b60005b600c54811015610fc757600b6000600c8381548110610e4f57fe5b60009182526020808320909101546001600160a01b039081168452908301939093526040909101902054600f55601654600c8054919092169163a9059cbb9184908110610e9857fe5b6000918252602080832090910154600f546040805163ffffffff871660e01b81526001600160a01b03909316600484015260248301919091525160448083019491928390030190829087803b158015610ef057600080fd5b505af1158015610f04573d6000803e3d6000fd5b505050506040513d6020811015610f1a57600080fd5b5050600c8054600b9160009184908110610f3057fe5b60009182526020808320909101546001600160a01b031683528201929092526040018120819055600c8054600792919084908110610f6a57fe5b60009182526020808320909101546001600160a01b03168352820192909252604001812080546001600160a01b03199081168255600182810184905560028301849055600383019390935560049091018054909116905501610e34565b5060005b600c54811015610ac457600c805480610fe057fe5b600082815260209020810160001990810180546001600160a01b0319169055019055600101610fcb565b6001600160a01b03811661101d57600080fd5b6110278282610dfc565b1561103157600080fd5b6001600160a01b0316600090815260209190915260409020805460ff19166001179055565b6001600160a01b03811661106957600080fd5b6110738282610dfc565b61107c57600080fd5b6001600160a01b0316600090815260209190915260409020805460ff1916905556fe73656e646572206973206e6f7420617574686f726973656420666f7220667572746865722070726f63657373696e67a165627a7a72305820dd5c585c1e2cf21b33269c44363d6a5c425a2119bb7443d0f05b336f1ac4d12e0029";

        public BookRunner() : base(BYTECODE) { }

        public BookRunner(string byteCode) : base(byteCode) { }

        [Parameter("address", "token_address", 1)]
        public virtual string TokenAddress { get; set; }

        [Parameter("address", "_investor", 2)]
        public virtual string Investor { get; set; }

        [Parameter("string", "name", 3)]
        public virtual string Name { get; set; }

        [Parameter("string", "isin", 4)]
        public virtual string ISIN { get; set; }

        [Parameter("uint8", "_decimalUnits", 5)]
        public virtual byte DecimalUnits { get; set; }

        [Parameter("address", "_lead_book_runner", 6)]
        public virtual string Lead_Book_Runner { get; set; }

        [Parameter("string", "inv_type", 7)]
        public virtual string Inv_type { get; set; }

        [Parameter("string", "_bond_name", 8)]
        public virtual string Bond_Name { get; set; }

        [Parameter("int", "_bond_min_price", 9)]
        public virtual int Bond_Min_Price { get; set; }

        [Parameter("int", "_bond_max_price", 10)]
        public virtual int Bond_Max_Price { get; set; }

        [Parameter("int", "_bond_total_lots", 11)]
        public virtual int Bond_Total_Lots { get; set; }

    }
}